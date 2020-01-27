module.exports = function (grunt) {
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        clean: ["wwwroot/css/*"],
        postcss: {
            options: {
                map: true, // inline sourcemaps
                processors: [
                    require('tailwindcss')(),
                    require('autoprefixer') // add vendor prefixes
                ]
            },
            dist: {
                expand: true,
                cwd: 'src/css/',
                src: ['*.css'],
                dest: 'wwwroot/css/',
                ext: '.css'
            }
        },
        watch: {
            postcss: {
                files: 'src/css/**/*.css',
                tasks: ['compile-css'],
                options: {
                    interrupt: true
                }
            }
        }
    });
    
    grunt.loadNpmTasks("grunt-contrib-clean");
    grunt.loadNpmTasks("grunt-postcss");
    grunt.loadNpmTasks('grunt-contrib-watch');
    
    grunt.registerTask('compile-css', ['clean', 'postcss']);
    grunt.registerTask('watch-css', ['watch:postcss']);
};